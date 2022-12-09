import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HomeComponent } from './home/home.component';
import { CardapioComponent } from './cardapio/cardapio.component';
import { CoreModule } from '../core/core.module';
import { PromocaoComponent } from './cardapio/promocao/promocao.component';
import { PizzaComponent } from './cardapio/pizza/pizza.component';
import { EntradaComponent } from './cardapio/entrada/entrada.component';
import { SobremesaComponent } from './cardapio/sobremesa/sobremesa.component';
import { BebidaComponent } from './cardapio/bebida/bebida.component';
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatButtonModule } from '@angular/material/button';
import { MatDividerModule } from '@angular/material/divider';

@NgModule({
  declarations: [
    HomeComponent,
    CardapioComponent,
    PromocaoComponent,
    PizzaComponent,
    EntradaComponent,
    SobremesaComponent,
    BebidaComponent,
  ],
  imports: [
    CommonModule,
    CoreModule,
    MatSidenavModule,
    MatButtonModule,
    MatDividerModule,
  ],
  exports: [
    HomeComponent,
    CardapioComponent,
    PromocaoComponent,
    PizzaComponent,
    EntradaComponent,
    SobremesaComponent,
    BebidaComponent,
  ],
})
export class PagesModule {}
