
        function mostrarTabelaColheitas() {
            document.getElementById("detalhesTexto").innerText = ''; // Limpa o texto dos detalhes
            document.getElementById("tabelaColheitas").style.display = "block"; // Exibe a tabela de colheitas
            document.getElementById("tabelaPrevisao").style.display = "none"; // Esconde a tabela de previsão
            document.getElementById("tabelaFornecedores").style.display = "none"; // Esconde a tabela de fornecedores
            document.getElementById("graficoIrrigacao").style.display = "none"; // Esconde o gráfico
            document.getElementById("modalDetalhes").style.display = "flex";
        }

        function mostrarTabelaPrevisao() {
            document.getElementById("detalhesTexto").innerText = ''; // Limpa o texto dos detalhes
            document.getElementById("tabelaColheitas").style.display = "none"; // Esconde a tabela de colheitas
            document.getElementById("tabelaPrevisao").style.display = "block"; // Exibe a tabela
            document.getElementById("tabelaFornecedores").style.display = "none"; // Esconde a tabela de fornecedores
            document.getElementById("graficoIrrigacao").style.display = "none"; // Esconde o gráfico
            document.getElementById("modalDetalhes").style.display = "flex";
        }

        function mostrarTabelaFornecedores() {
            document.getElementById("detalhesTexto").innerText = ''; // Limpa o texto dos detalhes
            document.getElementById("tabelaColheitas").style.display = "none"; // Esconde a tabela de colheitas
            document.getElementById("tabelaPrevisao").style.display = "none"; // Esconde a tabela de previsão
            document.getElementById("tabelaFornecedores").style.display = "block"; // Exibe a tabela de fornecedores
            document.getElementById("graficoIrrigacao").style.display = "none"; // Esconde o gráfico
            document.getElementById("modalDetalhes").style.display = "flex";
        }

        

        function fecharModal() {
            document.getElementById("modalDetalhes").style.display = "none";
        }

        function gerarGrafico() {
            const ctx = document.getElementById('graficoFalhas').getContext('2d');
            const graficoFalhas = new Chart(ctx, {
                type: 'bar', // Tipo de gráfico
                data: {
                    labels: ['Estufa 1', 'Estufa 2', 'Estufa 3'],
                    datasets: [{
                        label: 'Porcentagem de Falhas (%)',
                        data: [30, 50, 20], // Valores de exemplo
                        backgroundColor: 'rgba(255, 99, 132, 0.2)',
                        borderColor: 'rgba(255, 99, 132, 1)',
                        borderWidth: 1
                    }]
                },
                options: {
                    scales: {
                        y: {
                            beginAtZero: true,
                            title: {
                                display: true,
                                text: 'Porcentagem (%)'
                            }
                        },
                        x: {
                            title: {
                                display: true,
                                text: 'Estufas'
                            }
                        }
                    }
                }
            });
        }