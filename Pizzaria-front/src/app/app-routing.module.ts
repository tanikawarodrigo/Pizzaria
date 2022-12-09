import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { BebidaComponent } from './pages/cardapio/bebida/bebida.component';
import { CardapioComponent } from './pages/cardapio/cardapio.component';
import { EntradaComponent } from './pages/cardapio/entrada/entrada.component';
import { PizzaComponent } from './pages/cardapio/pizza/pizza.component';
import { PromocaoComponent } from './pages/cardapio/promocao/promocao.component';
import { SobremesaComponent } from './pages/cardapio/sobremesa/sobremesa.component';
import { HomeComponent } from './pages/home/home.component';

const routes: Routes = [
  { path: '', component: HomeComponent },
  {
    path: 'pedido',
    component: CardapioComponent,
    children: [
      { path: 'promocao', component: PromocaoComponent },
      { path: 'pizza', component: PizzaComponent },
      { path: 'entrada', component: EntradaComponent },
      { path: 'sobremesa', component: SobremesaComponent },
      { path: 'bebida', component: BebidaComponent },
    ],
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
