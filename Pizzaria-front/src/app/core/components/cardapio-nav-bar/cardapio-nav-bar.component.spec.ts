import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CardapioNavBarComponent } from './cardapio-nav-bar.component';

describe('CardapioNavBarComponent', () => {
  let component: CardapioNavBarComponent;
  let fixture: ComponentFixture<CardapioNavBarComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CardapioNavBarComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CardapioNavBarComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
