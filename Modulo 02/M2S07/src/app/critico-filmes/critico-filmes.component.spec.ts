import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CriticoFilmesComponent } from './critico-filmes.component';

describe('CriticoFilmesComponent', () => {
  let component: CriticoFilmesComponent;
  let fixture: ComponentFixture<CriticoFilmesComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [CriticoFilmesComponent]
    });
    fixture = TestBed.createComponent(CriticoFilmesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
