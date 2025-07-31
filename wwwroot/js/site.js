
const tableBody = document.getElementById("tableBody");
const rows = Array.from(tableBody.querySelectorAll("tr"));
const paginationControls = document.getElementById("paginationControls");
const searchInput = document.getElementById("searchInput");
const entriesPerPageSelect = document.getElementById("entriesPerPage");

let currentPage = 1;
let rowsPerPage = parseInt(entriesPerPageSelect.value);

function filterRows() {
    const keyword = searchInput.value.toLowerCase();
    return rows.filter(row => {
        const namaCell = row.querySelector("td")?.innerText.toLowerCase();
        return namaCell.includes(keyword);
    });
}

function renderTable() {
    const filtered = filterRows();
    const totalPages = rowsPerPage === 'All' ? 1 : Math.ceil(filtered.length / rowsPerPage);
    currentPage = Math.min(currentPage, totalPages || 1);

    tableBody.innerHTML = "";

    const start = rowsPerPage === 'All' ? 0 : (currentPage - 1) * rowsPerPage;
    const end = rowsPerPage === 'All' ? filtered.length : start + rowsPerPage;

    filtered.slice(start, end).forEach(row => tableBody.appendChild(row));
    renderPaginationControls(totalPages);
}

function renderPaginationControls(totalPages) {
    paginationControls.innerHTML = "";

    if (rowsPerPage === 'All') return; // Hide pagination if showing all

    for (let i = 1; i <= totalPages; i++) {
        const btn = document.createElement("button");
        btn.textContent = i;
        btn.className = `px-3 py-1 rounded ${i === currentPage ? 'bg-blue-600 text-white' : 'bg-white border border-gray-300 hover:bg-gray-100'}`;
        btn.addEventListener("click", () => {
            currentPage = i;
            renderTable();
        });
        paginationControls.appendChild(btn);
    }
}

searchInput.addEventListener("input", () => {
    currentPage = 1;
    renderTable();
});

entriesPerPageSelect.addEventListener("change", () => {
    const value = entriesPerPageSelect.value;
    rowsPerPage = value === 'All' ? 'All' : parseInt(value);
    currentPage = 1;
    renderTable();
});

// Initial render
renderTable();

function toggleCollapse(id) {
    const el = document.getElementById(id);
    el.classList.toggle('hidden');
}

//untuk hamburger
const hamburgerBtn = document.getElementById('hamburgerBtn');
const sidebar = document.getElementById('sidebar');

hamburgerBtn.addEventListener('click', () => {
    if (sidebar.classList.contains('-translate-x-full')) {
        sidebar.classList.remove('-translate-x-full');
    } else {
        sidebar.classList.add('-translate-x-full');
    }
});
