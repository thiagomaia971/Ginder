package br.unifor.dispositivos.ginder.ui.perfil

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.ArrayAdapter
import android.widget.Toast
import br.unifor.dispositivos.ginder.R
import kotlinx.android.synthetic.main.activity_perfil.*

class PerfilActivity : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_perfil)

        val meusJogos = listOf("CSGO", "WOW", "LOL")

        list_meusJogos.adapter = ArrayAdapter(this, android.R.layout.simple_list_item_1, meusJogos)

        list_meusJogos.setOnItemClickListener { parent, view, position, id ->
            Toast.makeText(this, meusJogos[position], Toast.LENGTH_SHORT).show()
        }


    }


}
