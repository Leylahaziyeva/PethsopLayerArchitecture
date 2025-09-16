function addToWishlist(productId) {
    fetch('/wishlist/addToWishlist/' + productId, {
        method: 'POST',
        headers: { 'Content-Type': 'application/json' }
    })
        .then(response => {
            if (response.ok) {
                alert('Added to wishlist!');
            } else {
                alert('Failed to add product to wishlist.');
            }
        })
        .catch(error => {
            console.error('Error:', error);
            alert('An error occurred while adding the product to the wishlist.');
        });
}
function removeFromWishlist(productId, element) {
    fetch('/wishlist/removeFromWishlist/' + productId, {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        }
    })
        .then(response => {
            if (response.ok) {
                element.closest('tr').remove(); 
            } else {
                alert('Failed to remove product from wishlist.');
            }
        })
        .catch(error => {
            console.error('Error:', error);
            alert('An error occurred while removing the product from the basket.');
        });
}