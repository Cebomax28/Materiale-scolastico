import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
// Importo JSON per caricamento dati iniziali
import workersJson from './workers.json'
// Importo componente workers
import { Lavoratore, Worker } from "../worker/worker";

@Component({
  imports: [FormsModule, CommonModule, Worker],
  selector: 'app-workers-list',
  styleUrl: './workers-list.css',
  templateUrl: './workers-list.html',
})
export class WorkersList {
  public workers: Lavoratore[] = workersJson;
  mestieri: string[] = ['Muratore', 'Idraulico', 'Elettricista', 'Falegname', 
      'Imbianchino', 'Giardiniere', 'Meccanico', 'Cuoco'];
  
  // Definizione dei valori iniziali (BINDING-BIDIREZIONALE)
  nome: string = '';
  cognome: string = '';
  mestiere: string = 'Muratore';
  disponibile: boolean = true;
  anniEsperienza: number = 0;
  icon: any = "";

  addWorker(): void{
      const nuovoWorker: Lavoratore = {
        nome: this.nome,
        cognome: this.cognome,
        mestiere: this.mestiere,
        disponibile: this.disponibile,
        anniEsperienza: this.anniEsperienza,
        icon: "ICONA",
      }
      this.workers.push(nuovoWorker);
  };



}
