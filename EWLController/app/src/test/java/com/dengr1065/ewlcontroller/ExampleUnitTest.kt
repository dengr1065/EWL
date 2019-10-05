package com.dengr1065.ewlcontroller

import org.junit.Test

import org.junit.Assert.*

class ConnectionTest {
    @Test
    fun testConnection() {
        val conn = EWLConnection("127.0.0.1")
        conn.setOnPacketListener {
            System.out.println("got packet")
            System.out.println(it[0])
        }
        conn.start()
        while (true) {
            Thread.sleep(500)
            conn.sendPacket(0x00, null)
            conn.sendPacket(0x02, null)
            conn.sendPacket(0x03, byteArrayOf(0x0A))
            conn.sendPacket(0x06, byteArrayOf(0x01))
        }
    }
}
