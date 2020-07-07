package br.unifor.dispositivos.ginder.data

import java.net.URLEncoder

public abstract class Repository {
    val baseUrl: String = "http://3ed398cad9ee.ngrok.io";
    abstract val actionUrl: String;

    protected fun Encode(value: String): String {
        return URLEncoder.encode(value, "UTF-8")
    }

    protected fun CreateUrl(): String {
        return "${baseUrl}${actionUrl}"
    }
}