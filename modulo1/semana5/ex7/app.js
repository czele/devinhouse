import Partida from "./Partida.js";
import Time from "./Time.js"

const corinthians = new Time("corinthians", "cor", 0, 0, 0, 0, 0);
const palmeiras = new Time("palmeiras", "pal", 0, 0, 0, 0, 0);
const santos = new Time("santos", "san", 0, 0, 0, 0, 0);
const fluminense = new Time("fluminense", "flu", 0, 0, 0, 0, 0);
const flamengo = new Time("flamengo", "fla", 0, 0, 0, 0, 0);

const partida1 = new Partida("cor", 2, "pal", 0);
const partida2 = new Partida("san", 1, "cor", 0)
const partida3 = new Partida("pal", 1, "cor", 1);


corinthians.computarPartida(partida1);
corinthians.computarPartida(partida2);
corinthians.computarPartida(partida3);
console.log(corinthians.exibirSituacao());
