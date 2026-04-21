document.addEventListener('DOMContentLoaded', () => {
    const root = document.querySelector('.company-directory-page');
    if (!root) {
        return;
    }

    const searchInput = document.getElementById('searchInput');
    const divisionFilter = document.getElementById('divisionFilter');
    const locationFilter = document.getElementById('locationFilter');
    const roleFilter = document.getElementById('roleFilter');
    const clearFiltersBtn = document.getElementById('clearFiltersBtn');
    const contactCount = document.getElementById('contactCount');
    const emptyState = document.getElementById('noDirectoryResults');
    const rows = Array.from(document.querySelectorAll('#directoryTableBody tr'));

    const normalize = (value) => (value || '').toString().trim().toLowerCase();

    const applyFilters = () => {
        const keyword = normalize(searchInput?.value);
        const division = normalize(divisionFilter?.value);
        const location = normalize(locationFilter?.value);
        const role = normalize(roleFilter?.value);

        let visibleRows = [];

        rows.forEach((row) => {
            const haystack = [
                row.dataset.name,
                row.dataset.position,
                row.dataset.division,
                row.dataset.location,
                row.dataset.extension,
                row.dataset.email,
                row.dataset.role
            ].map(normalize).join(' ');

            const rowDivision = normalize(row.dataset.division);
            const rowLocation = normalize(row.dataset.location);
            const rowRole = normalize(row.dataset.role);

            const matchesKeyword = !keyword || haystack.includes(keyword);
            const matchesDivision = !division || rowDivision === division;
            const matchesLocation = !location || rowLocation === location;
            const matchesRole = !role || rowRole.includes(role);

            const matches = matchesKeyword && matchesDivision && matchesLocation && matchesRole;
            row.hidden = !matches;
            row.classList.remove('is-highlighted');

            if (matches) {
                visibleRows.push(row);
            }
        });

        if (visibleRows.length > 0) {
            visibleRows[0].classList.add('is-highlighted');
        }

        if (contactCount) {
            contactCount.textContent = `${visibleRows.length} contact${visibleRows.length > 1 ? 's' : ''}`;
        }

        if (emptyState) {
            emptyState.hidden = visibleRows.length !== 0;
        }
    };

    [searchInput, divisionFilter, locationFilter, roleFilter].forEach((element) => {
        if (!element) return;
        element.addEventListener('input', applyFilters);
        element.addEventListener('change', applyFilters);
    });

    if (clearFiltersBtn) {
        clearFiltersBtn.addEventListener('click', () => {
            if (searchInput) searchInput.value = '';
            if (divisionFilter) divisionFilter.value = '';
            if (locationFilter) locationFilter.value = '';
            if (roleFilter) roleFilter.value = '';
            applyFilters();
            searchInput?.focus();
        });
    }

    applyFilters();
});
