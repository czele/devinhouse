export default class Funcionario {
    constructor (cpf, nome, salario) {
        this.cpf = cpf;
        this.nome = nome;
        this.salario = salario;

        let soma = 0;
        this.cpfVal = false;
        
        for (let i = 0; i < this.cpf.length; i++) {
            if(!isNaN(this.cpf[i])) {
            soma += parseInt(this.cpf[i]) 
            console.log(soma)}   
        }

        if (soma % 11 == 0) {
            this.cpfVal = true;
        }
    };
    
    promover (porcentagem) {
        if (this.cpfVal = true) {
            this.salario *= (1 + (porcentagem/100));
            return this.salario;
        };
    }

    validarCpf () {
        console.log('funcionou');
    }
}