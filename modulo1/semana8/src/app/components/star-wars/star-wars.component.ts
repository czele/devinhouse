import { PersonagemClass } from './personagem-class';
import { StarWarsServiceService } from '../../star-wars.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-star-wars',
  templateUrl: './star-wars.component.html',
  styleUrls: ['./star-wars.component.css']
})
export class StarWarsComponent implements OnInit {

  public personagens: PersonagemClass[] = [];

  constructor (private _service: StarWarsServiceService) {}

  ngOnInit(): void {
    
    this._service.getPersonagens().subscribe(res => {this.personagens = res})
    
  }
}

