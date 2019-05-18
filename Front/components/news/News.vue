<template>
<div class="card">
  <div class="card-image">
    <figure class="image is-4by3">
      <img :src=news.image alt="Placeholder image">
    </figure>
  </div>
  <div class="card-content">
    <div class="media">
      <div class="media-left">
        <figure class="image is-48x48">
          <img :src=news.auteurImage alt="Placeholder image">
        </figure>
      </div>
      <div class="media-content">
        <p class="title is-4">{{news.auteur}}</p>
      </div>
    </div>

    <div class="content">
      {{news.text}}
      <a :href=news.link>{{news.linkLabel}}</a>
      <br>
      <time datetime=news.date>{{news.date}}</time>
    </div>
  </div>
</div>
</template>
<script>
export default {
    name: 'News',
    props: ['news']
}
</script>
