import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatButtonModule } from '@angular/material/button';
import { MatTabsModule } from '@angular/material/tabs';
import { HomeNavBarComponent } from './components/home-nav-bar/home-nav-bar.component';
import { CardapioNavBarComponent } from './components/cardapio-nav-bar/cardapio-nav-bar.component';
import { MatCardModule } from '@angular/material/card';
import { DeliveryCardComponent } from './components/delivery-card/delivery-card.component';
import { ProdutoCardComponent } from './components/produto-card/produto-card.component';
import { RouterModule } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';
import { CartComponent } from './components/cart/cart.component';
import { MatDividerModule } from '@angular/material/divider';
import { MatListModule } from '@angular/material/list';
import { CartFooterComponent } from './components/cart-footer/cart-footer.component';
import { MatInputModule } from '@angular/material/input';
@NgModule({
  declarations: [
    HomeNavBarComponent,
    CardapioNavBarComponent,
    DeliveryCardComponent,
    ProdutoCardComponent,
    CartComponent,
    CartFooterComponent,
  ],
  imports: [
    CommonModule,
    MatToolbarModule,
    MatButtonModule,
    MatTabsModule,
    MatCardModule,
    RouterModule,
    HttpClientModule,
    MatDividerModule,
    MatListModule,
    MatInputModule,
  ],
  exports: [
    HomeNavBarComponent,
    CardapioNavBarComponent,
    DeliveryCardComponent,
    ProdutoCardComponent,
    CartComponent,
    CartFooterComponent,
  ],
})
export class CoreModule {}
