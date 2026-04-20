document.addEventListener("DOMContentLoaded", function () {
    const searchInput = document.getElementById("directorySearch");
    const sectionSelect = document.getElementById("directorySection");
    const resetButton = document.getElementById("directoryReset");
    const rows = Array.from(document.querySelectorAll(".directory-row"));
    const resultCount = document.getElementById("directoryResultCount");
    const emptyState = document.getElementById("directoryEmptyState");
    const table = document.getElementById("directoryTable");

    if (!searchInput || !sectionSelect || !resetButton || rows.length === 0 || !resultCount || !emptyState || !table) {
        return;
    }

    function normalize(value) {
        return (value || "").toString().trim().toLowerCase();
    }

    function applyFilters() {
        const searchValue = normalize(searchInput.value);
        const sectionValue = normalize(sectionSelect.value);
        let visibleCount = 0;

        rows.forEach(function (row) {
            const rowSearch = normalize(row.getAttribute("data-search"));
            const rowSection = normalize(row.getAttribute("data-section"));

            const matchesSearch = searchValue === "" || rowSearch.includes(searchValue);
            const matchesSection = sectionValue === "" || rowSection === sectionValue;
            const isVisible = matchesSearch && matchesSection;

            row.style.display = isVisible ? "" : "none";

            if (isVisible) {
                visibleCount += 1;
            }
        });

        resultCount.textContent = visibleCount.toString();
        emptyState.style.display = visibleCount === 0 ? "block" : "none";
        table.style.display = visibleCount === 0 ? "none" : "table";
    }

    searchInput.addEventListener("input", applyFilters);
    sectionSelect.addEventListener("change", applyFilters);

    resetButton.addEventListener("click", function () {
        searchInput.value = "";
        sectionSelect.value = "";
        applyFilters();
        searchInput.focus();
    });

    applyFilters();
});
