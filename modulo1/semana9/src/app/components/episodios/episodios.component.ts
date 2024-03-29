import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-episodios',
  templateUrl: './episodios.component.html',
  styleUrls: ['./episodios.component.css']
})
export class EpisodiosComponent implements OnInit {

  constructor(private route: ActivatedRoute) { }
  ngOnInit(): void {
  }

  public temporadaId = this.route.snapshot.paramMap.get('id');
  public serieEscolhida = this.route.snapshot.paramMap.get('serie');

  public dados = [
    {
      serie: "Mad Men",
      serieRota: "madmen",
      temporada: "1",
      episodios: [
        { numEpisodio: 1, nomeEpisodio: "Smoke Gets in Your Eyes", duracao: "49 min", plot: "In 1960 New York City - the high-powered and glamorous Golden Age of advertising - Don Draper, the biggest ad man in the business, struggles to stay a step ahead of the rapidly changing times and the young executives nipping at his heels", foto: "https://api.time.com/wp-content/uploads/2014/03/mms7_key-art-credit-milton-glaseramc.jpg" },
        { numEpisodio: 2, nomeEpisodio: "Ladies Room", duracao: "47 min", plot: "Don continues to conceal his complicated personal life, even in the face of Roger's invitation to open up.", foto: "https://cdnb.artstation.com/p/assets/images/images/005/591/047/large/pierre-parisato-madmen-def-rvb.jpg?1492255574" },
        { numEpisodio: 3, nomeEpisodio: "Marriage of Figaro", duracao: "45 min", plot: "Pete returns home from his honeymoon excited about his new marriage but conflicted about his past encounter with Peggy.", foto: "https://i.etsystatic.com/6285100/r/il/e4c145/299842655/il_794xN.299842655.jpg" },
        { numEpisodio: 4, nomeEpisodio: "New Amsterdam", duracao: "46 min", plot: "Pete Campbell oversteps the mark when he pitches an idea for ad campaign to the head of Bethlehem Steel without telling Don Draper. Draper wants him fired but learns a lesson in corporate politics. Pete's wife wants to buy a Manhattan apartment but he has to approach his cold and distant parents for a loan. Pete's in-laws, however, are more forthcoming.", foto: "https://compote.slate.com/images/612fb48b-ed53-47d6-914b-1e1d437b4abd.jpg?crop=1058%2C1605%2Cx0%2Cy0&width=1280" },
        { numEpisodio: 5, nomeEpisodio: "5G", duracao: "49 min", plot: "Don Draper is shaken when his past life comes back to haunt him. After his picture appears in a local newspaper, Adam Whitman, a man who claims to be his younger brother, approaches him.", foto: "https://images.fineartamerica.com/images/artworkimages/mediumlarge/1/work-and-drink-mad-men-poster-peggy-olson-quote-beautify-my-walls.jpg" },
        { numEpisodio: 6, nomeEpisodio: "Babylon", duracao: "47 min", plot: "The Agency is looking to land an advertising contract to promote tourism to Israel. Don and his team try to come up with a theme but know so little about the country that they're stumped. So Don calls Rachel Menken to see if she has any ideas.", foto: "https://dspncdn.com/a1/media/692x/80/c9/a8/80c9a84edc48e6a3b69da1644f6c482f.jpg" },
        { numEpisodio: 7, nomeEpisodio: "Red in the Face", duracao: "46 min", plot: "When Don invites Roger home for dinner, too much alcohol fuels repercussions between Don and Betty and between Don and Roger. Joan puts Roger off for the weekend, spending time with her roommate Carol instead", foto: "https://m.media-amazon.com/images/I/812iQTZLUfS._SL1500_.jpg" },
        { numEpisodio: 8, nomeEpisodio: "The Hobo Code", duracao: "47 min", plot: "Pete Campbell and Peggy Olson start an office romance. Peggy's copy for the lipstick account goes over well and the men in the firm congratulate her. A new telephone receptionist, Lois Saddler, takes a liking to Salvatore Romano but his own interests seem to lie elsewhere.", foto: "https://i.insider.com/4f1586e8ecad040235000036?width=400&format=jpeg&auto=webp" },
        { numEpisodio: 9, nomeEpisodio: "Shoot", duracao: "46 min", plot: "Don is courted by Jim Hobart, head of a larger ad firm who offers him more money and more creative resources to join them. Betty Draper rekindles her interest in modeling after Hobart suggests she should try it. She doesn't realize it's all part of the strategy to get Don on board.", foto: "http://1.bp.blogspot.com/_hZK2FqppiPw/TP58JvCxV5I/AAAAAAAAC2Y/4ix9Htb0trk/s1600/madmenposter+season1.jpg" },
        { numEpisodio: 10, nomeEpisodio: "Long Weekend", duracao: "46 min", plot: "It's Labor Day weekend and most of the men are sending their wives away for a few days. Don Draper's wife Betty is dreading the thought, as her father and his new girlfriend, whom she detests, will be staying with them.", foto: "https://photos.enjoei.com.br/poster-ilustrativo-decorativo-mad-men-59508227/828xN/czM6Ly9waG90b3MuZW5qb2VpLmNvbS5ici9wcm9kdWN0cy85MzE5MC8wNGExN2UwNmM3OTk5NTg4ZDZhNmMwNDY1YTM3YjU2Yi5qcGc" },
        { numEpisodio: 11, nomeEpisodio: "Indian Summer", duracao: "47 min", plot: "Peggy is given the opportunity to write copy for a new weight loss device that everyone knows is useless. She finds an interesting use for it, however. Afraid of losing the Lucky Strike cigarette account, Bert Cooper gets Roger Sterling to come in for a one-hour meeting but he has another attack.", foto: "https://preview.redd.it/6emlyrecd1611.png?width=640&crop=smart&auto=webp&v=enabled&s=2142fa9124647ee1ec654d52898e325edfe61c9f" },
        { numEpisodio: 12, nomeEpisodio: "Nixon vs. Kennedy", duracao: "47 min", plot: "Election night arrives and the staff of Sterling Cooper has a party while watching the returns. The election is close and it's obviously going to be a long night. Now a senior partner in the firm, Don Draper must hire a new head of account services, a post that Pete Campbell yearns for.", foto: "https://external-preview.redd.it/MUN7mYi40aiHPyPKXSpeJIoUoHj6veZFZ-yzyUf5Xqk.jpg?auto=webp&v=enabled&s=f3faf79aa4ff4000838c22be13dae8bed5ce1e7a" },
        { numEpisodio: 13, nomeEpisodio: "The Wheel", duracao: "52 min", plot: "Don and Betty Draper have an argument when it becomes apparent that he doesn't want to spend Thanksgiving with her family and she plans on going only with the children. He also learns some information about his brother Adam.", foto: "https://www.quadrorama.com.br/imagens/quadro-decorativo/?quadro=2022/11/Filme-Mad-Men-77f5118e.png" }
      ]
    },
    {
      serie: "Mad Men",
      serieRota: "madmen",
      temporada: "2",
      episodios: [
        { numEpisodio: 13, nomeEpisodio: "The Wheel", duracao: "52 min", plot: "Don and Betty Draper have an argument when it becomes apparent that he doesn't want to spend Thanksgiving with her family and she plans on going only with the children. He also learns some information about his brother Adam.", foto: "https://www.quadrorama.com.br/imagens/quadro-decorativo/?quadro=2022/11/Filme-Mad-Men-77f5118e.png" }
      ]
    }
  ]

  public serieClicada:any = this.dados.filter((e) => e.serieRota === this.serieEscolhida).filter((x) => x.temporada === this.temporadaId)[0].episodios;

}
