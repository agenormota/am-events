import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-events',
  templateUrl: './events.component.html',
  styleUrls: ['./events.component.scss']
})
export class EventsComponent implements OnInit {

  public events: any = [
    {
      theme: 'Angular',
      date: '12/05/2022',
      city: 'Montreal'
    },
    {
      theme: 'Angular + .Net',
      date: '12/05/2022',
      city: 'Quebec'
    },
    {
      theme: 'Angular + Java',
      date: '12/05/2022',
      city: 'Trois-Riviere'
    }
  ]
  constructor() { }

  ngOnInit(): void {
  }

}
