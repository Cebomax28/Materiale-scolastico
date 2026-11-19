import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';

// Importo JSON per caricamento dei dati iniziali
import workersJson from './workers.json';

@Component({
  imports: [FormsModule, CommonModule],
  selector: 'app-workers-list',
  styleUrl: './workers-list.css',
  templateUrl: './workers-list.html',
})
export class WorkersList {

  mestieri: string[] = ["Muratore", "Idraulico", "Elettrcista", "Falegname", "Imbianchino", "Giardiniere", "Meccanico", "Cuoco"];
  // Definizione dei valori iniziali
  nome: string = "";
  cognome: string = "";
  mestiere: string = "Muratore";
  disponibile: boolean = true;
  anniEsperienza: number = 0;
}
