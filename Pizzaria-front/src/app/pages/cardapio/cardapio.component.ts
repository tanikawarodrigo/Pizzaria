import { Component, Input, OnInit } from '@angular/core';
import { ProdutosService } from 'src/app/core/services/produtos.service';
import { Produto } from 'src/app/shared/models/produto.model';

@Component({
  selector: 'app-cardapio',
  templateUrl: './cardapio.component.html',
  styleUrls: ['./cardapio.component.css'],
})
export class CardapioComponent {
  @Input()
  produto!: Produto;
}
