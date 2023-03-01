import { Component } from '@angular/core';

@Component({
  selector: 'app-serie',
  templateUrl: './serie.component.html',
  styleUrls: ['./serie.component.css']
})
export class SerieComponent {

  public todosEpisodios: any = [
    {nome: "Ep1", duracao: "50min"},
    {nome: "Ep2", duracao: "45min"},
    {nome: "Ep3", duracao: "20min"}
  ];
}
