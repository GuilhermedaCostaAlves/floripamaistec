import { Component } from '@angular/core';
import { FilmesService } from './services/filmesService';
import { IFilmes } from './Interfaces/IFilmes';

@Component({
  selector: 'app-filmes',
  templateUrl: './filmes.component.html',
  styleUrls: ['./filmes.component.css']
})
export class FilmesComponent {
  carregando = false;
  filmesArray: IFilmes[] = [];
  filmeAtual: IFilmes | null = null;
  filmesTopTres: IFilmes[] | null = null;
  indiceFilme = 0;

  constructor(private filmesService: FilmesService) {
    this.filmesService.buscarFilmes().subscribe(resposta => {
      this.filmesArray = resposta
      this.carregando = false;
      this.filmesTopTres = this.filmesService.buscarTopTres(resposta);
      this.filmeAtual = this.filmesTopTres[0];
    });
  }

  buscarFilmes() {
    this.carregando = true;
    this.filmesService.buscarFilmes().subscribe(resposta => {
      this.filmesArray = resposta
      this.carregando = false;
    });
  }

  filmeBemAvaliado() {
    const resultado = this.filmesService.buscarFilmeMaisBemAvaliado(this.filmesArray);
    console.log(resultado);
  }

  proximo() {
    this.indiceFilme++;
    if (this.filmesTopTres != null)
      this.filmeAtual = this.filmesTopTres[this.indiceFilme];
  }

  anterior() {
    this.indiceFilme--;
    if (this.filmesTopTres != null)
      this.filmeAtual = this.filmesTopTres[this.indiceFilme];
  }
}
