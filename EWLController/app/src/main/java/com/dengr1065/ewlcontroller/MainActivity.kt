package com.dengr1065.ewlcontroller

import android.graphics.BitmapFactory
import android.os.Bundle
import android.support.design.widget.Snackbar
import android.support.v7.app.AppCompatActivity;
import android.view.Menu
import android.view.MenuItem

import kotlinx.android.synthetic.main.activity_main.*
import kotlinx.android.synthetic.main.content_main.*

class MainActivity : AppCompatActivity() {
    private var ewlConn: EWLConnection? = null

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        connect_fab.setOnClickListener {
            ConnectFragment().show(supportFragmentManager, "CONNECT_FRAG")
        }

        get.setOnClickListener {
            Thread {
                ewlConn?.sendPacket(0x00, null)
                ewlConn?.sendPacket(0x02, null)
                ewlConn?.sendPacket(0x03, byteArrayOf(0x0A))
                ewlConn?.sendPacket(0x06, byteArrayOf(0x01))
            }.start()
        }
    }

    override fun onCreateOptionsMenu(menu: Menu): Boolean {
        menuInflater.inflate(R.menu.menu_main, menu)
        return true
    }

    override fun onOptionsItemSelected(item: MenuItem): Boolean {
        return when (item.itemId) {
            R.id.action_settings -> true
            else -> super.onOptionsItemSelected(item)
        }
    }

    fun connect(serverIP: String) {
        if (ewlConn == null) {
            ewlConn = EWLConnection(serverIP)
            ewlConn!!.setOnPacketListener {
                when (it[0]) {
                    0xFE.toByte() -> { // client connect, proxy-only packet
                        runOnUiThread {
                            client_conn_text.text = String(it.copyOfRange(1, it.size - 2))
                        }
                    }
                    0xFF.toByte() -> { // client disconnect, proxy-only packet
                        runOnUiThread {
                            client_conn_text.setText(R.string.general_none)
                        }
                    }
                    0x00.toByte() -> { // system name
                        runOnUiThread {
                            system_name_text.text = String(it.copyOfRange(1, it.size))
                        }
                    }
                    0x02.toByte() -> { // user name
                        runOnUiThread {
                            user_name_text.text = String(it.copyOfRange(1, it.size))
                        }
                    }
                    0x03.toByte() -> { // screenshot
                        val bmp = BitmapFactory.decodeByteArray(it, 1, it.size - 1)
                        runOnUiThread {
                            screen_preview.setImageBitmap(bmp)
                        }
                    }
                    0x06.toByte() -> { // file manager
                        // TODO("Implement all FM packet types")
                    }
                }
            }
            ewlConn!!.start()
        }
    }
}
