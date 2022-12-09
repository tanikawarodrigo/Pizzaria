import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { ProdutosService } from 'src/app/core/services/produtos.service';
import { Produto } from 'src/app/shared/models/produto.model';

@Component({
  selector: 'app-bebida',
  templateUrl: './bebida.component.html',
  styleUrls: ['./bebida.component.css'],
})
export class BebidaComponent implements OnInit {
  @Output() produtoAdicionado = new EventEmitter();

  bebidas: Produto[] = [];

  constructor(private produtoService: ProdutosService) {}

  ngOnInit(): void {
    this.produtoService
      .getBebidaList()
      .subscribe((res) => (this.bebidas = res));
  }
}
