import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {
  
  formLogin!: FormGroup;
  public logado: boolean = false;
  public naoLogado: boolean = false;

  constructor(private fl:FormBuilder, private router: Router) { }

  private contas = [
    {login: "teste@teste.com", password: "123"},
  ] 

  ngOnInit() {
    this.formLogin = this.fl.group({
      email: ['', [Validators.required, Validators.email]],
      senha: ['', [Validators.required, Validators.pattern("^[0-9]*$")]]
    });
    localStorage.setItem("logado", "false");
  }

  onSubmit() {
    this.contas.forEach(e => {  
      if(e.login === this.formLogin.value.email && e.password === this.formLogin.value.senha) {
          this.logado = true;
          localStorage.setItem("logado", "true");
          window.alert("Login efetuado com sucesso");
          this.router.navigate(['/home']);
        } else {this.naoLogado = true}
    }); 
  }
}
