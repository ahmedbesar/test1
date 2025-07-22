import { Component, OnInit } from '@angular/core';
import { test1Service } from '../services/test1.service';

@Component({
  selector: 'lib-test1',
  template: ` <p>test1 works!</p> `,
  styles: [],
})
export class test1Component implements OnInit {
  constructor(private service: test1Service) {}

  ngOnInit(): void {
    this.service.sample().subscribe(console.log);
  }
}
