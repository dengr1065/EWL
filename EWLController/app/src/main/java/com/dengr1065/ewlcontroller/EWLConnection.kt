package com.dengr1065.ewlcontroller

import java.io.OutputStream
import java.net.InetAddress
import java.net.Socket
import java.nio.ByteBuffer
import java.nio.ByteOrder

class EWLConnection(serverIP: String) {
    private val thread: Thread
    private var socket: Socket? = null
    private var onPacketListener: ((ByteArray) -> Unit)? = null

    private var outputStream: OutputStream? = null

    init {
        val addr = InetAddress.getByName(serverIP)
        thread = Thread {
            socket = Socket(addr, 9005)
            val istream = socket!!.getInputStream()
            outputStream = socket!!.getOutputStream()

            while (true) {
                val sb = ByteArray(4)
                var sz: Int
                var pk: ByteArray?
                var read = 0
                while (read < 4) {
                    val rb = istream.read(sb, read, 4 - read)
                    if (rb <= 0) break
                    read += rb
                }
                val bb = ByteBuffer.wrap(sb)
                bb.order(ByteOrder.LITTLE_ENDIAN)
                sz = bb.int
                pk = ByteArray(sz)
                read = 0
                while (read < sz) {
                    val rb = istream.read(pk, read, sz - read)
                    if (rb <= 0) break
                    read += rb
                }
                onPacketListener?.invoke(pk)
            }
        }
    }

    fun start() {
        thread.start()
    }

    private fun intToByteArray(a: Int): ByteArray {
        val ret = ByteArray(4)
        ret[0] = (a and 0xFF).toByte()
        ret[1] = (a shr 8 and 0xFF).toByte()
        ret[2] = (a shr 16 and 0xFF).toByte()
        ret[3] = (a shr 24 and 0xFF).toByte()
        return ret
    }

    fun sendPacket(pid: Byte, data: ByteArray?) {
        val pkLen = if (data == null) 1 else data.size + 1
        outputStream!!.write(intToByteArray(pkLen))
        outputStream!!.write(byteArrayOf(pid))
        if (data != null) {
            outputStream!!.write(data)
        }
    }

    fun setOnPacketListener(listener: ((ByteArray) -> Unit)?) {
        onPacketListener = listener
    }
}