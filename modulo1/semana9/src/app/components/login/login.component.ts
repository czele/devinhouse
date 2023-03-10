import { Component } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {

  formLogin!: FormGroup;
  public logado: boolean = false;
  public naoLogado: boolean = false;

  constructor(private fl:FormBuilder) { }

  private contas = [
    {login: "teste@gmail.com", password: "123"},
    {login: "t1@gmail.com", password: "456"},
    {login: "t2@gmail.com", password: "456"},
    {login: "t3@gmail.com", password: "789"},
    {login: "t4@gmail.com", password: "111"}
  ] 

  ngOnInit() {
    localStorage.setItem("logado", "false");
    this.formLogin = this.fl.group({
      email: [''],
      senha: ['']
    });
  }

  onSubmit() {
    this.contas.forEach(e => {  
      if(e.login === this.formLogin.value.email && e.password === this.formLogin.value.senha) {
          this.logado = true;
          localStorage.setItem("logado", "true");
          window.alert("Login efetuado com sucesso");
        } else {this.naoLogado = true}
    }); 
  }
}
