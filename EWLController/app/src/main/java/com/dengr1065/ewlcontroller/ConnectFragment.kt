package com.dengr1065.ewlcontroller

import android.os.Bundle
import android.support.design.widget.BottomSheetDialogFragment
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.Button
import android.widget.EditText
import android.widget.LinearLayout

class ConnectFragment : BottomSheetDialogFragment() {
    override fun onCreateView(inflater: LayoutInflater, container: ViewGroup?, savedInstanceState: Bundle?): View? {
        val ll = inflater.inflate(R.layout.fragment_connect, container, false) as LinearLayout
        val ipField: EditText = ll.findViewById(R.id.ip_field)
        val connBtn: Button = ll.findViewById(R.id.connect_btn)

        connBtn.setOnClickListener {
            if (ipField.text.isNullOrEmpty()) return@setOnClickListener
            val act = activity as MainActivity
            act.connect(ipField.text.toString())
            dismiss()
        }

        return ll
    }
}