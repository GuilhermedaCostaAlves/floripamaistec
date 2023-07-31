import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { IFilmes } from '../Interfaces/IFilmes';
import { environment } from '../evironments/environments.devolpement';

@Injectable({
  providedIn: 'root'
})
export class FilmesService {

  constructor(private httpClient: HttpClient) { }

  buscarFilmes(){
    return this.httpClient.get<IFilmes[]>(environment.apiUrl + '/filmes/get-all')
  }

  buscarFilmeMaisBemAvaliado(filmesArray: IFilmes[]) {
    return filmesArray.reduce(function(filmePrev, filmeAtual) {
      return filmePrev.notaIMDb > filmeAtual.notaIMDb ? filmePrev : filmeAtual;
    });
  }

  buscarTopTres(filmesArray: IFilmes[]) {
    let filmesArrayCopia: IFilmes[] = filmesArray;
    let topTres: IFilmes[] = [];

    for (let index = 0; index < 3; index++) {
      topTres.push(this.buscarFilmeMaisBemAvaliado(filmesArrayCopia));
      filmesArrayCopia.splice(filmesArrayCopia.indexOf(topTres[index]), 1);
    }

    return topTres;
  }

}