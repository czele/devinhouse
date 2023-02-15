import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CarroselComponent } from './carrosel/carrosel.component';
import { GaleriaComponent } from './components/galeria/galeria.component';

@NgModule({
  declarations: [
    AppComponent,
    CarroselComponent,
    GaleriaComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
