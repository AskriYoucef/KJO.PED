document.addEventListener("DOMContentLoaded", function () {
    const header = document.querySelector(".site-header");
    if (!header) return;

    const syncHeaderState = () => {
        if (window.scrollY > 12) {
            header.classList.add("scrolled");
        } else {
            header.classList.remove("scrolled");
        }
    };

    syncHeaderState();
    window.addEventListener("scroll", syncHeaderState, { passive: true });
});
