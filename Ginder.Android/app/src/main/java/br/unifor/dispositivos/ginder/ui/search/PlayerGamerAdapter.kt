package br.unifor.dispositivos.ginder.ui.search

import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.ImageView
import android.widget.TextView
import androidx.databinding.DataBindingUtil
import androidx.recyclerview.widget.RecyclerView
import br.unifor.dispositivos.ginder.R


class PlayerGamerAdapter : RecyclerView.Adapter<PlayerGamerAdapter.ProfileViewHolder>() {

    private var playergamers: List<PlayerGamer>? = null

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int) = ProfileViewHolder(
        DataBindingUtil.inflate(
            LayoutInflater.from(parent.context),
            R.layout.playergame_card_view,
            parent,
            false
        )
    )

    override fun getItemCount() = playergamers?.size ?: 0

    override fun onBindViewHolder(holder: ProfileViewHolder, position: Int) {
        playergamers?.let {
            val profile = it[position]

            holder.textViewName.setText(profile.Name)
            holder.textViewGame.setText(profile.Game)
            holder.textViewPeriod.setText(profile.Period)
            holder.textViewRole.setText(profile.Role)
     //       holder.binding.executePendingBindings()
        }
    }

    fun setProfiles(profiles: List<PlayerGamer>) {
        this.playergamers = profiles
        notifyDataSetChanged()
    }
    //
//
//    inner class ProfileViewHolder(val binding: CardViewProfileBinding) :
//        RecyclerView.ViewHolder(binding.root)

    inner class ProfileViewHolder(itemView: View) :
        RecyclerView.ViewHolder(itemView) {
        var textViewName: TextView
        var textViewGame: TextView
        var textViewPeriod: TextView
        var textViewRole: TextView

        init {
            textViewName = itemView.findViewById(R.id.playergamer_name)
            textViewGame = itemView.findViewById(R.id.playergamer_game)
            textViewPeriod = itemView.findViewById(R.id.playergamer_period)
            textViewRole = itemView.findViewById(R.id.playergamer_role)
        }
    }
}