package br.unifor.dispositivos.ginder.ui.search

import android.content.Context
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.ArrayAdapter
import android.widget.TextView
import br.unifor.dispositivos.ginder.R
import br.unifor.dispositivos.ginder.data.model.PlayerGame

public class PlayerAdapter(context: Context, val resource: Int, val playerGames: List<PlayerGame>) :
    ArrayAdapter<PlayerGame>(context, resource, playerGames) {


    override fun getView(position: Int, convertView: View?, parent: ViewGroup): View {
        val inflater = LayoutInflater.from(context)
        val view = inflater.inflate(resource, null)

        val nameTextView = view.findViewById<TextView>(R.id.playergame_list_name)
        val periodTextView = view.findViewById<TextView>(R.id.playergame_list_period)
        val descriptionTextView = view.findViewById<TextView>(R.id.playergame_list_role)
        val gameId = view.findViewById<TextView>(R.id.playergame_list_gameId)

        val playerGame = playerGames[position]

        nameTextView.text = playerGame.Player?.Name
        periodTextView.text = playerGame.PeriodTime
        descriptionTextView.text = playerGame.Role
        gameId.text = playerGame.GameId.toString()


        return view
    }
}