import { StarWarsServiceService } from './../../star-wars-service.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-star-wars',
  templateUrl: './star-wars.component.html',
  styleUrls: ['./star-wars.component.css']
})
export class StarWarsComponent implements OnInit {

  public getInfoPersonagem1: string[] = [];
  public getInfoPersonagem2: string[] = [];

  constructor (private _service: StarWarsServiceService) {}

  ngOnInit(): void {
    this.getInfoServicePersonagem1();
    this.getInfoServicePersonagem2();
  }

  public getInfoServicePersonagem1() {
    return this.getInfoPersonagem1 = this._service.getPersonagem1();
  }

  public getInfoServicePersonagem2() {
    return this.getInfoPersonagem2 = this._service.getPersonagem2();
  }
}
