import { HttpClient } from '@angular/common/http';
import { EventEmitter, Injectable } from '@angular/core';
import { BehaviorSubject, empty } from 'rxjs';
import { Produto } from 'src/app/shared/models/produto.model';

@Injectable({
  providedIn: 'root',
})
export class ProdutosService {
  private readonly API = 'https://localhost:7248/Produto/';

  produtos: Produto[] = [];

  // private produto$ = new BehaviorSubject<any>({});
  // selectedProduto$ = this.produto$.asObservable();

  // setProduto(produto: any) {
  //   this.produto$.next(produto);
  // }

  constructor(private http: HttpClient) {}

  getBebidaList() {
    return this.http.get<Produto[]>(`${this.API}bebidas`);
  }
}
