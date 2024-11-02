// Importando as funções necessárias do Firebase
import { initializeApp } from "https://www.gstatic.com/firebasejs/11.0.1/firebase-app.js";
import { getFirestore, collection, addDoc, serverTimestamp } from "https://www.gstatic.com/firebasejs/11.0.1/firebase-firestore.js";

// Configuração do Firebase
const firebaseConfig = {
    apiKey: "AIzaSyDfObEb7L6mGjE2nrCXQvhv03kjZVO4sdw",
    authDomain: "green-city-8ef6b.firebaseapp.com",
    projectId: "green-city-8ef6b",
    storageBucket: "green-city-8ef6b.appspot.com",
    messagingSenderId: "624616315905",
    appId: "1:624616315905:web:ce74d73d8a7b33b3ac7400",
    measurementId: "G-C96WYV548C"
};

// Inicializando o Firebase
const app = initializeApp(firebaseConfig);
const db = getFirestore(app);

// Expondo a função no escopo global
window.cadastrarFornecedor = async function() {
    const nome = document.getElementById('nome').value;
    const cnpj = document.getElementById('cnpj').value;
    const telefone = document.getElementById('telefone').value;
    const email = document.getElementById('email').value;

    try {
        const docRef = await addDoc(collection(db, "fornecedores"), {
            nome: nome,
            cnpj: cnpj,
            telefone: telefone,
            email: email,
            ativo: true,
            criadoEm: serverTimestamp()
        });
        console.log("Fornecedor cadastrado com ID:", docRef.id);
        alert("Fornecedor cadastrado com sucesso!");

        // Limpando os campos do formulário
        document.getElementById('nome').value = "";
        document.getElementById('cnpj').value = "";
        document.getElementById('telefone').value = "";
        document.getElementById('email').value = "";

    } catch (error) {
        console.error("Erro ao cadastrar fornecedor:", error);
        alert("Erro ao cadastrar fornecedor. Tente novamente.");
    }
}

window.voltarParaTelaInicial = function() {
    window.location.href = "telainicial_usuario.html";
};
