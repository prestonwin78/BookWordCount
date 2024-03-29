import { Component, OnInit } from '@angular/core';
import { AuthService } from '../services/auth.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.scss']
})
export class NavComponent implements OnInit {

  public displayLoggedIn: boolean = false;

  constructor(public authService: AuthService) { }

  ngOnInit(): void {
    this.authService.isLoggedIn()
      .subscribe((isLoggedIn: boolean) => {
        this.displayLoggedIn = isLoggedIn;
      });
  }

}
