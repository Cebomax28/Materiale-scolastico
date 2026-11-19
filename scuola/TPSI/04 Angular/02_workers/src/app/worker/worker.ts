import { Component } from '@angular/core';
export interface Lavoratore{
  nome: string;
  cognome: string;
  mestiere: string;
  anniEsperienza: string;
  disponibile: string;
  icon: string;
}

@Component({
  imports: [],
  selector: 'app-worker',
  styleUrl: './worker.css',
  templateUrl: './worker.html',
})
export class Worker {

}
