package br.unifor.dispositivos.ginder.ui.perfil

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.*
import br.unifor.dispositivos.ginder.R
import kotlinx.android.synthetic.main.activity_perfil.*

class PerfilActivity : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_perfil)

        val meusJogos = listOf(
            PlayerGame("CSGO", "10 horas/dia", "Role..."),
            PlayerGame("LoL", "10 horas/dia", "Role..."),
            PlayerGame("WoW", "10 horas/dia", "Role...")
        )


        playergame_list.adapter = PlayerGameAdapter(this, R.layout.playergame_item, meusJogos)

        val listView = findViewById<ListView>(R.id.playergame_list);

        playergame_list.setOnItemClickListener {  parent, view, position, id ->
            Toast.makeText(this@PerfilActivity, view.findViewById<TextView>(R.id.playergame_list_title).text, Toast.LENGTH_SHORT).show()
        }
        }
    }

