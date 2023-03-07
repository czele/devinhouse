import { Component } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {

  formLogin!: FormGroup;

  constructor(private fl:FormBuilder) { }

  ngOnInit() {
    this.formLogin = this.fl.group({
      email: [''],
      senha: ['']
    });
  }

  onSubmit() {
    console.log(this.formLogin.value);
  }
}
