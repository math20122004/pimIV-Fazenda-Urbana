// Classe FornecedorService responsável por fazer requisições à API
class FornecedorService {
    constructor(apiUrl) {
        this.apiUrl = apiUrl;
    }

    async obterTodosFornecedores() {
        try {
            const response = await fetch(this.apiUrl, {
                headers: {
                    'Accept': 'application/json',
                    'User-Agent': 'learning app',
                }
            });

            if (!response.ok) {
                console.log(response);
                console.log(response)
                throw new Error(`Erro ao carregar fornecedores: ${response.status} - ${response.statusText}`);
            }
            return await response.json();
        } catch (error) {   
            console.error('Erro ao obter fornecedores:', error.message, error);
            throw error;
        }
    }
}

// Classe FornecedorController responsável por controlar a exibição dos dados
class FornecedorController {
    constructor(apiUrl) {
        this.fornecedorService = new FornecedorService(apiUrl);
    }

    async mostrarFornecedores() {
        const detalhes = document.getElementById("detalhes-fornecedor");

        if (!detalhes) {
            console.error('Elemento com ID "detalhes-fornecedor" não encontrado.');
            return;
        }

        detalhes.style.display = "block";

        try {
            const fornecedores = await this.fornecedorService.obterTodosFornecedores();
            let detalhesHTML = `
                <h3>Todos os Fornecedores</h3>
                <table>
                    <thead>
                        <tr>
                            <th>Nome</th>
                            <th>CNPJ</th>
                            <th>Email</th>
                            <th>ID</th>
                            <th>Endereço</th>
                            <th>Telefone 1</th>
                            <th>Status</th>
                        </tr>
                    </thead>
                    <tbody>`;

            fornecedores.forEach(fornecedor => {
                detalhesHTML += `
                    <tr>
                        <td>${fornecedor['nome'] || "Informação não disponível"}</td>
                        <td>${fornecedor['Cnpj'] || "Informação não disponível"}</td>
                        <td>${fornecedor.email || "Informação não disponível"}</td>
                        <td>${fornecedor.id || "Informação não disponível"}</td>
                        <td>${fornecedor.endereco || "Informação não disponível"}</td>
                        <td>${fornecedor.telefone_1 || "Informação não disponível"}</td>
                        <td>${fornecedor.status || "Informação não disponível"}</td>
                    </tr>`;
            });

            detalhesHTML += `
                    </tbody>
                </table>`;
            detalhes.innerHTML = detalhesHTML;
        } catch (error) {
            detalhes.innerHTML = '<p>Erro ao carregar fornecedores.</p>';
        }
    }
}

// Inicialização
const apiUrl = 'https://1241-2804-836c-0-1cb0-15d9-fc32-175d-cc3f.ngrok-free.app/fornecedores/'; // URL da API
const fornecedorController = new FornecedorController(apiUrl);

// Função de interface para exibir os fornecedores
function mostrarDetalhes() {
    fornecedorController.mostrarFornecedores();
}

// Adicionar o evento ao botão de exibir fornecedores
document.addEventListener('DOMContentLoaded', () => {
    const btnFornecedores = document.querySelector('.btn-fornecedor'); 

    if (btnFornecedores) {
        btnFornecedores.addEventListener('click', mostrarDetalhes);
    } else {
        console.error('Botão "btn-fornecedor" não encontrado.');
    }
});
