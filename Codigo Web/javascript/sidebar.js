// Função para alternar a sidebar (abrir e fechar)
document.getElementById('open_btn').addEventListener('click', function() {
    const sidebar = document.getElementById('sidebar');
    const mainContent = document.getElementById('main-content');

    // Alterna a classe "open-sidebar"
    sidebar.classList.toggle('open-sidebar');

    // Ajusta o padding do conteúdo principal
    if (sidebar.classList.contains('open-sidebar')) {
        mainContent.style.paddingLeft = 'calc(15% + 20px)';
    } else {
        mainContent.style.paddingLeft = 'calc(82px + 20px)';
    }
});

// Função para navegar entre as páginas e carregar conteúdo dinamicamente
function navigate(page) {
    const mainContent = document.getElementById('main-content');

    // Usa o fetch para carregar o conteúdo do arquivo HTML
    fetch(`${page}.html`)
        .then(response => {
            if (!response.ok) {
                throw new Error('Erro ao carregar a página');
            }
            return response.text();
        })
        .then(html => {
            // Substitui o conteúdo do mainContent pelo HTML carregado
            mainContent.innerHTML = html;
        })
        .catch(error => {
            mainContent.innerHTML = '<h1>Erro</h1><p>Não foi possível carregar a página solicitada.</p>';
            console.error('Erro:', error);
        });
}









