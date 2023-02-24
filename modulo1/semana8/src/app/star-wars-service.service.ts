import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class StarWarsServiceService {

  public personagem1: string[] = ["teste", "camila", "teste"]
  public personagem2: string[] = ["teste", "luquinhas", "teste"]

  public getPersonagem1():string[]{
    return this.personagem1;
  }

  public getPersonagem2():string[]{
    return this.personagem2;
  }

}
