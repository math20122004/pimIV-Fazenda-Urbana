async function mostrarDetalhesVendas() {
    const detalhes = document.getElementById("detalhes-pedido");
    detalhes.style.display = "block"; // Mostra a seção de detalhes

    try {
        const response = await fetch('https://apigreencity-217994129978.southamerica-east1.run.app/vendas/');
        
        if (!response.ok) {
            throw new Error(`Erro HTTP! Status: ${response.status}`);
        }

        const vendas = await response.json();
        console.log(vendas); // Exibe a estrutura para depuração

        // Criando a estrutura da tabela
        let detalhesHTML = `
            <h3>Detalhes das Vendas</h3>
            <table>
                <thead>
                    <tr>
                        <th>Nome Cliente</th>
                        <th>ID Venda</th>
                        <th>CPF</th>
                        <th>Email</th>
                        <th>Status Cliente</th>
                        <th>Status Pedido</th>
                        <th>Número Pedido</th>
                        <th>Lote</th>
                        <th>Quantidade</th>
                        <th>Valor Total</th>
                        <th>CEP</th>
                    </tr>
                </thead>
                <tbody>
        `;

        // Preenchendo as linhas da tabela com as informações de cada venda
        vendas.forEach(venda => {
            detalhesHTML += `
                <tr>
                    <td>${venda.cliente?.nome || "Informação não disponível"}</td>
                    <td>${venda.id || "Informação não disponível"}</td>
                    <td>${venda.cliente?.cpf || "Informação não disponível"}</td>
                    <td>${venda.cliente?.email || "Informação não disponível"}</td>
                    <td>${venda.cliente?.status || "Informação não disponível"}</td>
                    <td>${venda.status}</td>
                    <td>${venda.numero}</td>
                    <td>${venda.venda?.id_lote || "Informação não disponível"}</td>
                    <td>${venda.venda?.quantidade || "Informação não disponível"}</td>
                    <td>${venda.venda?.valor_total || "Informação não disponível"}</td>
                    <td>${venda.cliente?.cep || "Informação não disponível"}</td>
            `;
        });

        // Fechando a estrutura da tabela
        detalhesHTML += `
                </tbody>
            </table>
        `;

        // Inserindo a tabela no elemento de detalhes
        detalhes.innerHTML = detalhesHTML;

    } catch (error) {
        console.error('Erro ao buscar vendas:', error);
        detalhes.innerHTML = '<p>Erro ao carregar vendas. Tente novamente mais tarde.</p>';
    }
}

function ocultarDetalhesVendas() {
    const detalhes = document.getElementById("detalhes-pedido");
    detalhes.style.display = "none"; // Oculta a seção de detalhes
}
