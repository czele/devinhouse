import Personagem from "./Personagem.js";

const alyx = new Personagem("Alyx"); 
    console.log(alyx.percentualVida); 
    alyx.sofreuDano(50);
    console.log(alyx.percentualVida);
    alyx.usouKitMedico();
    console.log(alyx.percentualVida);
    alyx.sofreuDano(50);
    console.log(alyx.percentualVida);
    alyx.sofreuDano(50);
    console.log(alyx.percentualVida);
