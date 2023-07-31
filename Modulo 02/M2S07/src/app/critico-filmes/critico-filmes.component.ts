import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import {HttpClientModule}from '@angular/common/http';

@Component({
  selector: 'app-critico-filmes',
  templateUrl: './critico-filmes.component.html',
  styleUrls: ['./critico-filmes.component.css']
})
export class CriticoFilmesComponent {
  avaliacaoForm: FormGroup;

  constructor() {
    this.avaliacaoForm = new FormGroup({
      'nome': new FormControl('', [Validators.required, Validators.minLength(3)]),
      'email': new FormControl('', [Validators.required, Validators.email]),
      'nomeFilme': new FormControl('', [Validators.required, Validators.minLength(3)]),
      'avaliacao': new FormControl(null, [Validators.required, Validators.min(1), Validators.max(10)]),
    });
  }

  enviarFormulario() {
    const nomeFilme = this.avaliacaoForm.get('nomeFilme')?.value;
    alert(`Você avaliou o filme ${nomeFilme}`);
  }
}
