$(function () {
	$('.ima1, .ima2, .ima3').hover(function () {
		$(this).animate({ marginTop: '-=20px' }, 200);
	}, function () {
			$(this).animate({ marginTop: '+=20px' }, 200);
	});
});