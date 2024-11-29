// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

document.addEventListener('DOMContentLoaded', function () {
    const dropdownToggle = document.getElementById('dropdownToggle');
    const dropdownMenu = document.getElementById('dropdownMenu');

    // Toggle the dropdown visibility when clicking on the dropdownToggle
    dropdownToggle.addEventListener('click', function (e) {
        e.preventDefault();
        // Toggle visibility of the dropdown menu
        if (dropdownMenu.classList.contains('hidden')) {
            dropdownMenu.classList.remove('hidden');
            dropdownToggle.setAttribute('aria-expanded', 'true');
            dropdownToggle.setAttribute('aria-haspopup', 'true');
        } else {
            dropdownMenu.classList.add('hidden');
            dropdownToggle.setAttribute('aria-expanded', 'false');
            dropdownToggle.setAttribute('aria-haspopup', 'false');
        }
    });

    // Close the dropdown if clicking anywhere outside the toggle or dropdown
    document.addEventListener('click', function (event) {
        // Check if the clicked element is outside both the dropdownToggle and dropdownMenu
        if (!dropdownToggle.contains(event.target) && !dropdownMenu.contains(event.target)) {
            setTimeout(() => {
                dropdownMenu.classList.add('hidden');
                dropdownToggle.setAttribute('aria-expanded', 'false');
                dropdownToggle.setAttribute('aria-haspopup', 'false');
            }, 0); // Ensure the click propagation has finished
        }
    });
});