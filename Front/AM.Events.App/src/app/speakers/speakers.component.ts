import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-speakers',
  templateUrl: './speakers.component.html',
  styleUrls: ['./speakers.component.scss']
})
export class SpeakersComponent implements OnInit {

  public speakers :any;

  constructor(private http:HttpClient ) { }

  ngOnInit(): void {
    this.getSpeakers();
  }

  public getSpeakers() : void {

    this.http.get('https://localhost:7121/event').subscribe(
      response => this.speakers = response,
      error => console.log(error)
    );

  }

}
