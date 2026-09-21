# Programas VSC 🛠️

Pasta dedicada ao desenvolvimento e armazenamento de **pequenos projetos e ferramentas locais para uso pessoal**.

Cada subpasta contém um aplicativo utilitário independente, desenvolvido com tecnologias web (HTML/CSS/JS) e estruturado para execução rápida e local no desktop (em modo aplicativo standalone).

---

## 📂 Projetos Atuais

### 1. [Silence Remover](./SIlence%20Remover/)
* **Descrição:** Ferramenta para detecção e remoção automática de silêncios e pausas em arquivos de áudio.
* **Recursos:**
  * Suporte a múltiplos arquivos simultâneos (upload em lote via Drag & Drop).
  * Fila interativa com status e tempo economizado por áudio em tempo real.
  * Prévia com reprodutor de áudio e visualização de forma de onda (*waveform*) comparativa.
  * Download individual em `.wav` ou de todos os arquivos juntos em pacote `.zip` (100% offline).
  * Executável próprio (`Silence Remover.exe`) com inicialização direta em janela de app.

### 2. [Transcribr](./Transcribr/)
* **Descrição:** Ferramenta local para transcrição e manipulação de áudio.
* **Recursos:**
  * Interface direta e responsiva para tarefas de transcrição.
  * Executável dedicado (`Transcribr.exe`) para acesso rápido no desktop.

---

## 🚀 Como Executar os Aplicativos

1. Acesse a pasta do projeto desejado (ex: `SIlence Remover/`).
2. Dê um duplo clique no executável correspondente (ex: `Silence Remover.exe`) para abrir como um aplicativo independente.
3. Alternativamente, é possível abrir diretamente o arquivo `.html` em qualquer navegador web.

---

## 📌 Padrão de Organização

Para novos utilitários criados nesta pasta:
* Crie uma subpasta exclusiva para o programa.
* Mantenha a interface no arquivo `.html`.
* Inclua ícones (`app_icon.ico`, `app_icon.png`) e o executável `.exe` de inicialização para manter o padrão desktop.

