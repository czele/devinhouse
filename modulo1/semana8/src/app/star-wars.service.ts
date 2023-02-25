import { PersonagemClass } from './components/star-wars/personagem-class';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { API_PATH } from './components/star-wars/enviroments/enviroments';

@Injectable({
  providedIn: 'root'
})
export class StarWarsServiceService {

  constructor(private _httpClient: HttpClient) {}

  public getPersonagens(): Observable<PersonagemClass[]> {
    return this._httpClient.get<PersonagemClass[]>(`${API_PATH}`);
  }

}
