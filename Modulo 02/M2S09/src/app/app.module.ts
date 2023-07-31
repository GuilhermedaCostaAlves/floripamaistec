import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { HomeComponent } from './componnents/home/home.component';
import { PulicComponent } from './componnents/pulic/pulic.component';
@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    PulicComponent,
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
