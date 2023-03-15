import { Component } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {

  public produtos = [
    {id: "1", nome: "mesa", quantidade: "3", preco: "R$ 1.200,00"},
    {id: "2", nome: "cadeira", quantidade: "6", preco: "R$ 800,00"},
    {id: "3", nome: "cama", quantidade: "3", preco: "R$ 2.500,00"},
  ]

  public limparLocal () {
    localStorage.clear();
  }
}
