package br.unifor.dispositivos.ginder.ui.perfil

import android.content.Context
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.ArrayAdapter
import android.widget.ImageView
import android.widget.TextView
import br.unifor.dispositivos.ginder.R

public class PlayerGameAdapter(context: Context, val resource: Int, val playerGames: List<PlayerGame>) :
    ArrayAdapter<PlayerGame>(context, resource, playerGames) {


    override fun getView(position: Int, convertView: View?, parent: ViewGroup): View {
        val inflater = LayoutInflater.from(context)
        val view = inflater.inflate(resource, null)

        val iconImageView = view.findViewById<ImageView>(R.id.playergame_list_icon)
        val titleTextView = view.findViewById<TextView>(R.id.playergame_list_title)
        val periodTextView = view.findViewById<TextView>(R.id.playergame_list_period)
        val descriptionTextView = view.findViewById<TextView>(R.id.playergame_list_role)

        val playerGame = playerGames[position]

        titleTextView.text = playerGame.Title
        periodTextView.text = playerGame.Period
        descriptionTextView.text = playerGame.Role



        return view
    }
}
