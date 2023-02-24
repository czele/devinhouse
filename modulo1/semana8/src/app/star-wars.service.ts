import { Personagem } from './components/star-wars/personagem';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class StarWarsServiceService {

  private url = 'http://localhost:3000/personagens';

  constructor(private _httpClient: HttpClient) {}

  public getPersonagens(): Observable<Personagem[]> {
    return this._httpClient.get<Personagem[]>(this.url);
  }

}
