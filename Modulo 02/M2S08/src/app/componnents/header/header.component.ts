import { Component } from '@angular/core';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent {
  idade = 35;
  textoInputIdade = 'Insira um texto';

  onClick() {
    alert('Botão clicado');
  }

  onMouseOver() {
    alert('MouseOver');
  }

  onMouseOut() {
    alert('MouseOut');
  }

};

