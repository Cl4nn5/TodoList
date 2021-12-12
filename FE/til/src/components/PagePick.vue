<template>
  <div class="container">
    <div class="card" v-for="(item, i) in cardCollection" :key="i">
      <div class="content">
        <h2>{{ item.title }}</h2>
        <p>{{ item.text }}</p>
        <a href="javascript:void(0);">Read More</a>
      </div>
      <img :src="item.img.src" :alt="item.img.alt" />
    </div>
    <!-- <div class="card">
      <div class="content">
        <h2>h2 Text</h2>
        <p>Lorem ipsum dolor sit amet consectetur adipisicing elit.</p>
        <a href="#">Read More</a>
      </div>
      <img src="../assets/images/sam.png" alt="오른쪽이미지" />
    </div> -->
  </div>
</template>

<script>
export default {
  name: "Pagepick",

  data() {
    return {
      cardCollection: [
        // card1
        {
          title: "nathan",
          text: "nathan에 대한 소개글",
          img: {
            src: '',
            alt: "왼쪽이미지",
          },
        },
        // card2
        {
          title: "sam",
          text: "sam에 대한 어쩌구 저쩌구",
          img: {
            src: '',
            alt: "오른쪽이미지",
          },
        },
      ],
    };
  },
  created() {
    this.init();
  },

  mounted() {},

  methods: {
  init() {
      this.cardCollection = [
        // card1
        {
          title: "nathan",
          text: "nathan에 대한 소개글",
          img: {
            src: require("../assets/images/nathan.png"),
            alt: "왼쪽이미지",
          },
        },
        // card2
        {
          title: "sam",
          text: "sam에 대한 어쩌구 저쩌구",
          img: {
            src: require("../assets/images/sam.png"),
            alt: "오른쪽이미지",
          },
        },
      ]
    },
  },
};
</script>

<style scoped>
.container {
  position: relative;
  display: flex;
  justify-content: center;
  align-items: center;
}
.container .card {
  position: relative;
  width: 37.5rem;
  height: var(--height-card);
  margin: 1.25rem;
  display: flex;
  justify-content: flex-start;
  align-items: center;
  background: linear-gradient(45deg, #1a2f3f, #7094ce);
  transition: var(--transition-delay-card);
}
.container .card img {
  position: absolute;
  bottom: 0%;
  height: calc(var(--height-card) + 3.125rem);
  left: 50%;
  transform: translateX(-50%);
  transition: var(--transition-delay-card);
}
.container .card:hover img {
  left: 70%;
  height: calc(var(--height-card) + 6.25rem);
}
.container .card .content {
  position: relative;
  width: 50%;
  left: 20%;
  padding: 1.25rem 1.25rem 1.25rem 2.5rem;
  opacity: 0;
  visibility: hidden;
  transition: var(--transition-delay-card);
}
.container .card .content h2 {
  color: #fff;
  text-transform: uppercase;
  font-size: 2.2em;
  line-height: 1em;
}
.container .card .content p {
  color: #fff;
}
.container .card .content a {
  position: relative;
  color: #111;
  background: #fff;
  display: inline-block;
  padding: 0.625rem 1.25rem;
  margin-top: 0.625rem;
  font-weight: 700;
}
.container .card:hover .content {
  left: 0;
  opacity: 1;
  visibility: visible;
}

@media screen and (max-width: 1016px) {
  .container{
        flex-direction: column;
    }
  .container .card {
    width: auto;
    align-items: flex-start;
  }

  .container .card:hover {
    height: calc(var(--height-card) * 2 - 100px);
  }

  .container .card:hover img {
    left: 50%;
    height: var(--height--card);
  }
  .container .card .content {
    width: 100%;
    left: 0;
    padding: 2.5rem;
  }
}
</style>