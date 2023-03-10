import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit{
  
  constructor(private route: ActivatedRoute) {}

  public temporadas = [
    { nomeSerie: "madmen", id:"1", numeroTemporada: "Primeira", numeroEpisodios: 13, ano: 2007, tumbnail: "https://mixdeseries.com.br/wp-content/uploads/2020/07/Mad-Men-serie.webp"},
    { nomeSerie: "madmen", id:"2", numeroTemporada: "Segunda", numeroEpisodios: 13, ano: 2008, tumbnail: "https://seriemaniacos.tv/wp-content/uploads/2011/07/Mad-Men-647x420.jpg"},
    { nomeSerie: "madmen", id:"2", numeroTemporada: "Terceira", numeroEpisodios: 13, ano: 2009, tumbnail: "https://wallpapercave.com/wp/t3wf2jG.jpg"},
    { nomeSerie: "madmen", id:"2", numeroTemporada: "Quarta", numeroEpisodios: 13, ano: 2010, tumbnail: "https://wallpapercave.com/w/GXcsYJb.jpg"},
    { nomeSerie: "madmen", id:"2", numeroTemporada: "Quinta", numeroEpisodios: 13, ano: 2012, tumbnail: "https://wallpapercave.com/dwp1x/7QeNMi4.jpg"},
    { nomeSerie: "madmen", id:"2", numeroTemporada: "Sexta", numeroEpisodios: 13, ano: 2013, tumbnail: "https://wallpapercave.com/dwp1x/IncmFe0.jpg"},
    { nomeSerie: "madmen", id:"2", numeroTemporada: "Sétima", numeroEpisodios: 14, ano: 2014, tumbnail: "https://wallpapercave.com/dwp1x/Mcqpg3p.jpg"},
  ]

  ngOnInit() {
  }
}
