import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-galeria',
  templateUrl: './galeria.component.html',
  styleUrls: ['./galeria.component.css']
})
export class GaleriaComponent {

  public title = 'Galeria de Imagens';
  @Input() public fotos: string[ ] = [ ];
  public fotoAtual = 0;

  public voltarParaPrimeira () {
    this.fotoAtual = this.primeira()
  }

  public vaiParaProxima() {
    return this.fotoAtual++;
  }

  public voltarParaAnterior(){
    this.fotoAtual--;
  }

  public vaiParaUltima() {
    this.fotoAtual = this.ultima();
  }

  public primeira() {
    return 0;
  }

  public ultima() {
    return this.fotos.length -1
  }

}
